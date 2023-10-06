using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;
using ZastitaProjekatServis.EnigmaCode;

namespace ZastitaProjekatServis
{
    public class ServiceZI : IServiceZI
    {

        private const uint DELTA = 0x9E3779B9;
        public ServiceZI() {}

        #region CRC
        public uint Crc32(byte[] podaci)
        {
            uint crc = 0xffffffff;
            for (int i = 0; i < podaci.Length; i++)
            {
                crc ^= podaci[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 1) != 0)
                        crc = (crc >> 1) ^ 0xEDB88320;
                    else
                        crc = (crc >> 1);
                }
            }
            return ~crc;
        }
        #endregion

        #region RC4

        public byte[] DekriptujRC4(byte[] podaci, byte[] kljuc)
        {
            return EnkriptujRC4(podaci, kljuc);
            throw new NotImplementedException();
        }

        public byte[] EnkriptujRC4(byte[] podaci, byte[] kljuc)
        {


            //  Key Scheduling Algorithm
            int[] S = new int[256];
            int i;
            for (i = 0; i < 256; i++)
            {
                S[i] = i;
            }

            int[] pomocniNiz = new int[256];


            //ako je kljuc duzine 256 samo ga kopiramo u pomocni niz
            if (kljuc.Length == 256)
            {
                Buffer.BlockCopy(kljuc, 0, pomocniNiz, 0, kljuc.Length);
            }
            //ako je duzina kljuca veca od 256 smanjujemo duzinu na 256
            else
            {
                i = 0;
                for (i = 0; i < 256; i++)
                {
                    pomocniNiz[i] = kljuc[i % kljuc.Length];
                }
            }

            int j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + pomocniNiz[i]) % 256;


                (S[j], S[i]) = (S[i], S[j]);
                /*int temp = S[i];
                S[i] = S[j];
                S[j] = temp;*/
            }


            //  Pseudo random generation algorithm 
            i = j = 0;
            byte[] result = new byte[podaci.Length];
            for (int index = 0; index < podaci.Length; index++)
            {

                i = (i + 1) % 256;

                j = (j + S[i]) % 256;

                (S[j], S[i]) = (S[i], S[j]);
                /*int temp = S[i];
                S[i] = S[j];
                S[j] = temp;*/

                int K = S[(S[i] + S[j]) % 256];
                result[index] = Convert.ToByte(podaci[index] ^ K);
            }

            //  return the result
            return result;
            //throw new NotImplementedException();
        }

        #endregion

        #region TEA
        public byte[] DekriptujTEA(byte[] podaci, byte[] kljuc)
        {
            uint[] k = new uint[4];
            byte[] kodiraniPodaci = new byte[podaci.Length];


            for (int i = 0; i < kljuc.Length; i += 4)
            {
                k[i / 4] = BitConverter.ToUInt32(kljuc, i);
            }

            //deljenje kljuca na 4 vrednosti
            uint k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];

            for (int i = 0; i < podaci.Length; i += 8)
            {

                uint v0 = BitConverter.ToUInt32(podaci, i);
                uint v1 = BitConverter.ToUInt32(podaci, i + 4);
                uint sum = 0xC6EF3720;

                for (int j = 0; j < 32; j++)
                {
                    v1 -= ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
                    v0 -= ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
                    sum -= DELTA;
                }

                byte[] v0Bajtovi = BitConverter.GetBytes(v0);
                byte[] v1Bajtovi = BitConverter.GetBytes(v1);
                for (int j = 0; j < 4; j++)
                {
                    kodiraniPodaci[i + j] = v0Bajtovi[j];
                    kodiraniPodaci[i + j + 4] = v1Bajtovi[j];
                }

            }

            return kodiraniPodaci;

        }

        public byte[] EnkriptujTEA(byte[] podaci, byte[] kljuc)
        {
            //podaci i kljuc duzina

            uint[] k = new uint[4];
            byte[] kodiraniPodaci = new byte[podaci.Length];


            for (int i = 0; i < kljuc.Length; i += 4)
            {
                k[i / 4] = BitConverter.ToUInt32(kljuc, i);
            }

            //deljenje kljuca na 4 vrednosti
            uint k0 = k[0], k1 = k[1], k2 = k[2], k3 = k[3];

            for (int i = 0; i < podaci.Length; i += 8)
            {

                uint v0 = BitConverter.ToUInt32(podaci, i);
                uint v1 = BitConverter.ToUInt32(podaci, i +4);
                uint sum = 0;

                for (int j = 0; j < 32; j++)
                {
                    sum += DELTA;
                    v0 += ((v1 << 4) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
                    v1 += ((v0 << 4) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
                }

                byte[] v0Bajtovi = BitConverter.GetBytes(v0);
                byte[] v1Bajtovi = BitConverter.GetBytes(v1);
                for (int j = 0; j < 4; j++)
                {
                    kodiraniPodaci[i + j] = v0Bajtovi[j];
                    kodiraniPodaci[i + j + 4] = v1Bajtovi[j];
                }

            }

            return kodiraniPodaci; 


        }

        #endregion

        #region TEA_CBC_Mode

   
        public byte[] EnkriptujTEA_CBC_Mode(byte[] podaci, byte[] kljuc, byte[] IV) { 
        
            if (podaci.Length % 8 != 0)
            {
                return null;
            }


            if (kljuc.Length != 16)
            {
                return null;
            }

            //iv mora biti 8 bajta
            //

            if (IV.Length != 8)
            {
                return null;
            }

            byte[] kodiraniPodaci = Array.Empty<byte>();

            uint[] uintIV = new uint[2];
            uintIV[0] = BitConverter.ToUInt32(IV, 0);
            uintIV[1] = BitConverter.ToUInt32(IV, 4);
            uint[] uintBlock = new uint[2]; 

            for (int i = 0; i < podaci.Length; i += 8)
            {
                var block = podaci.Skip(i).Take(8).ToArray();
                uintBlock[0] = BitConverter.ToUInt32(block, 0);
                uintBlock[1] = BitConverter.ToUInt32(block, 4);

                uintBlock[0] = uintBlock[0] ^ uintIV[0];
                uintBlock[1] = uintBlock[1] ^ uintIV[1];

                var block_bytes = BitConverter.GetBytes(uintBlock[0]);
                block_bytes = block_bytes.Concat(BitConverter.GetBytes(uintBlock[1])).ToArray();
                
                var crypted_block_bytes = EnkriptujTEA(block_bytes, kljuc);

                kodiraniPodaci = kodiraniPodaci.Concat(crypted_block_bytes).ToArray();


                //Smestamo Ci u IV tako da se ulancava kodirani blok sa sledecim blokom
                uintIV[0] = BitConverter.ToUInt32(crypted_block_bytes, 0);
                uintIV[1] = BitConverter.ToUInt32(crypted_block_bytes, 4);

            }






            return kodiraniPodaci;
        }

        public byte[] DekriptujTEA_CBC_Mode(byte[] podaci, byte[] kljuc , byte[] IV) {

            if (podaci.Length % 8 != 0)
            {
                return null;
            }

            if (kljuc.Length  != 16)
            {
                return null;
            }

            if (IV.Length != 8)
            {
                return null;
            }


            byte[] dekodiraniPodaci = Array.Empty<byte>();
            uint[] uintDecodedBlock = new uint[2];

            uint[] uintIV = new uint[2];
            uintIV[0] = BitConverter.ToUInt32(IV, 0);
            uintIV[1] = BitConverter.ToUInt32(IV, 4);

            for (int i = 0; i < podaci.Length; i += 8)
            {
                var block = podaci.Skip(i).Take(8).ToArray();


                var decoded_block_bytes = DekriptujTEA(block, kljuc);

                uintDecodedBlock[0] = BitConverter.ToUInt32(decoded_block_bytes, 0);
                uintDecodedBlock[1] = BitConverter.ToUInt32(decoded_block_bytes, 4);

                uintDecodedBlock[0] = uintDecodedBlock[0] ^ uintIV[0];
                uintDecodedBlock[1] = uintDecodedBlock[1] ^ uintIV[1];

                dekodiraniPodaci = dekodiraniPodaci.Concat(BitConverter.GetBytes(uintDecodedBlock[0])).ToArray();
                dekodiraniPodaci = dekodiraniPodaci.Concat(BitConverter.GetBytes(uintDecodedBlock[1])).ToArray();


                uintIV[0] = BitConverter.ToUInt32(block, 0);
                uintIV[1] = BitConverter.ToUInt32(block, 4);

            }
            return dekodiraniPodaci;

        }


        #endregion

        #region ENIGMA
        public Rotor StrToRotor(string r)
        {
            switch (r)
            {
                case "I": return new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q');
                case "II": return new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E');
                case "III": return new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V');
                case "IV":return new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J');
                case "V":return new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z');
                default: return null;


            }
        }

        public Reflector StrToReflector(string r)
        {
            switch (r)
            {
                case "A": return new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
                case "B": return new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
                case "C": return new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

                default: return null;


            }
        }

        public string EnkriptujENIGMA(string podaci, string ringovi, string kljuc, string reflektor,string r1, string r2, string r3, List<string> plugboardParovi)
        {

           /* Reflector A = new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
            Reflector B = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
            Reflector C = new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

            Rotor I = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q');
            Rotor II = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E');
            Rotor III = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V');
            Rotor IV = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J');
            Rotor V = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z');*/

            Plugboard pb = new Plugboard(plugboardParovi);
            Keyboard kb = new Keyboard();

            //kreiranje enigma masine
            Enigma enigma = new Enigma(StrToReflector(reflektor), StrToRotor(r1), StrToRotor(r2), StrToRotor(r3), pb, kb);

            //postavljanje ringova
            (int,int,int) rings = (ringovi[0] - '0', ringovi[1] - '0', ringovi[2] - '0');
            enigma.set_rings(rings);

            //postavljanje kljuca
            enigma.set_key(kljuc);


            var cipher_text = "";
            foreach (char c in podaci)
            {
                cipher_text = cipher_text + enigma.Encrypt(c);
            }
            return cipher_text;

        }

        public string DekriptujENIGMA(string podaci, string ringovi, string kljuc, string reflektor,string r1, string r2, string r3, List<string> plugboardParovi)
        {
            return EnkriptujENIGMA(podaci, ringovi, kljuc, reflektor, r1, r2, r3, plugboardParovi);

        }

        #endregion
    }

}
