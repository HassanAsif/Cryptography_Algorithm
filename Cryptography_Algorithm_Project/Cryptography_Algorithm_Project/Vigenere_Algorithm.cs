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
                // If-Statement remove spaces and symbols from the text like ...
                //If we have text "@Hassan Asif!" 
                //then this if-statement true when string value contain spaces or symbols like ! @
                if (get_charac < 'A' || get_charac > 'Z' & get_charac!=32)
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
  //Function for decrypting the encrypting message
          public string decrypt_message(string get_encrypted_text)
            {
                string decrypt_text = "";
                int size_text = get_encrypted_text.Length;
                int size_key = get_key.Length;
                
                for (int i = 0; i < size_text; i++)
                {
                    char get_character = get_encrypted_text[i];
                    if (get_encrypted_text[i] < 'A' || get_encrypted_text[i] > 'Z')
                    {
                        continue;
                    }
                    //decrypt_text=
                    
                }
                return decrypt_text;

              
            }

        
    }
}
