using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography_Algorithm_Project
{
    class Vigenere_Algorithm
    {
         public string get_key;
        public Vigenere_Algorithm(string key)  //Constructor "Getting Key from main"
        {
             get_key = key; 
        }
        public string encrypt_message(string get_message) //Function to encrypt message using given key
        {
            string encrypted_text="";
            int size_text = get_message.Length;
            int size_key = get_key.Length;
            for(int i=0,j=0;i<size_text;i++)
            {
                char get_charac = get_message[i];
                if (get_charac < 'A' || get_charac > 'Z')
                {
                    continue;
                }
                int get_data=0;
                 get_data+= (get_charac + get_key[j] - 2 * 'A') % 26 + 'A';
                //converting ASCII-Code into characters
                 char get_data2 = Convert.ToChar(get_data);
                 encrypted_text += get_data2.ToString();
                j = (j + 1) % size_key;
            }
            
            return encrypted_text;
        }
  


        
    }
}
