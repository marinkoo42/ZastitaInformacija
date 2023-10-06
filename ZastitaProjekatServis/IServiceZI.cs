using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ZastitaProjekatServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceZI
    {


        // TODO: Add your service operations here

        [OperationContract]
        uint Crc32(byte[] podaci);

        [OperationContract]
        byte[] EnkriptujRC4(byte[] podaci, byte[] kljuc);

        [OperationContract]
        byte[] DekriptujRC4(byte[] podaci,  byte[] kljuc);


        [OperationContract]
        byte[] EnkriptujTEA(byte[] podaci, byte[] kljuc);

        [OperationContract]
        byte[] DekriptujTEA(byte[] podaci, byte[] kljuc);

        [OperationContract]
        byte[] EnkriptujTEA_CBC_Mode(byte[] podaci, byte[] kljuc, byte[] IV);

        [OperationContract]
        byte[] DekriptujTEA_CBC_Mode(byte[] podaci, byte[] kljuc, byte[] IV);



        [OperationContract]
        string EnkriptujENIGMA(string podaci, string ringovi, string kljuc,string reflektor, string r1, string r2, string r3, List<string> plugboardParovi);

        [OperationContract]
        string DekriptujENIGMA(string podaci, string ringovi, string kljuc, string reflektor,string r1, string r2, string r3, List<string> plugboardParovi);
    }


}
