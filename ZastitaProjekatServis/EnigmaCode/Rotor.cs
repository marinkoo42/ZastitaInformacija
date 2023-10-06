using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

   /* var I = Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ","Q");
    var II = Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE","E");
    var III = Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO","V");
    var IV = Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB","J");
    var V = Rotor("VZBRGITYUPSDNHLXAWMJQOFECK","Z");*/
namespace ZastitaProjekatServis.EnigmaCode
{
    public class Rotor
    {
        public string left, right;
        public char _notch;

        public Rotor(string wiring, char notch)
        {

            this.left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.right = wiring;
            this._notch = notch;
        }

        public int forward(int signal)
        {
            var letter = this.right[signal];
            signal = this.left.IndexOf(letter);
            return signal;
        }

        public int backward(int signal)
        {
            var letter = this.left[signal];
            signal = this.right.IndexOf(letter);
            return signal;

        }
        public void show()
        {
            Console.WriteLine(this.left);
            Console.WriteLine(this.right);
        }

        public void rotate(int num_of_rotations = 1, bool forward = true)
        {
            for (int i = 0; i < num_of_rotations; i++)
            {
                if (forward)
                {
                    this.left = this.left.Substring(1) + this.left[0];
                    this.right = this.right.Substring(1) + this.right[0];
                }
                else
                {
                    this.left = this.left[25] + this.left.Substring(0, 25);
                    this.right = this.right[25] + this.right.Substring(0, 25);
                }
            }

        }

        public void rotate_to_letter(char letter)
        {
            var num_of_rotations = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(letter);
            this.rotate(num_of_rotations);
        }

        public void set_ring(int n)
        {
            


            //rotate the rotor backwards

            // n-1 jer je 1 default pozicija, kada je napravljena enigma nije se kretalo od 0 (nije se koristio zero based indexing)
            this.rotate(n - 1, false);

            //adjust the notch in relationship to the wiring
            var n_notch = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(this._notch);
            this._notch = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[(n_notch - n) % 26];
        }

    }

}