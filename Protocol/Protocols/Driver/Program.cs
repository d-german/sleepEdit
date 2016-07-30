using System;
using System.Collections.Generic;
using System.Text;
using Protocols;


namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtocolNode node = new ProtocolNode();
            ProtocolManager.load(node);
            ProtocolManager.save(node, @"F:\protocol_out.xml");
            

            

            


            int i = 0;
            

           
            
           

     
           
//             for (int i = 0; i < 20; i++)
//             {
//                 System.Console.WriteLine(System.Guid.NewGuid().ToString());
//             }

        }
     
    }
}
