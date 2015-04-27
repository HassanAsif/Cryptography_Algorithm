#include<iostream>
#include<bitset>
#include<string>
#include<time.h>
using namespace std;
class Vigenere
{
private:
	string plainText;
	string keyword;
public:
	string getKey()
	{
		return keyword;
	}
	void setKey(string s)
	{
		keyword=s;
	}
	void removeSpaces()
	{
		string str;
		str="";
		for(unsigned int i=0;i<plainText.length();i++)
		{
			if(plainText[i]!=' ')
			{
				str.resize(str.size()+1,plainText[i]);
			}
		}
		setPlainText(str);
	}
	void setPlainText(string aPlainText)
	{
		plainText=aPlainText;
	}
	string generateKey()
	{
		int i=0,j=0;
		string alphabets="abcdefghijklmnopqrstuvwxyz";
		string key="";
		cout<<"length of key is : "<<keyword.length()<<endl;
		for(i=0;i<plainText.length();i++)
		{
			key.resize(key.size()+1,keyword[j]);
			j++;
			if(j==keyword.length())
				j=0;
		}
		keyword=key;
		return key;
	}
	string encrypt(string aPlainText,string aKey)
	{
		int ch,k;
		string cipherStr="";
		string alphabets="abcdefghijklmnopqrstuvwxyz";
		setPlainText(aPlainText);
		setKey(aKey);
		removeSpaces();
		string key=generateKey();
		for(unsigned int i=0;i<plainText.length();i++)
		{
			for(unsigned int j=0;j<alphabets.length();j++)
			{
				if(plainText[i]==alphabets[j])
				{
					ch=j;
				}
				if(key[i]==alphabets[j])
					k=j;
			}
			cipherStr.resize(cipherStr.size()+1,cipher(ch,k));
		}
		return cipherStr;
	}
	string decrypt(string aPlainText,string key)
	{
		int ch,k;
		string cipherStr="";
		string alphabets="abcdefghijklmnopqrstuvwxyz";
		setPlainText(aPlainText);
		for(unsigned int i=0;i<plainText.length();i++)
		{
			for(unsigned int j=0;j<alphabets.length();j++)
			{

				if(plainText[i]==alphabets[j])
				{
					ch=j;
				}
				if(key[i]==alphabets[j])
					k=j;
			}
			cipherStr.resize(cipherStr.size()+1,decipher(ch,k));
		}
		return cipherStr;
	}
	char cipher(int ch,int k)
	{

		int r=(ch+k)%26;
		string alphabets="abcdefghijklmnopqrstuvwxyz";
		return alphabets[r];
	}
	char decipher(int ch,int k)
	{
		int r=(ch-k);
		if(r<0)
			r=(r+26)%26;
		else
			r=r%26;
		string alphabets="abcdefghijklmnopqrstuvwxyz";
		return alphabets[r];
	}
};
void main()
{
	string message,key;
	Vigenere v;
	cout<<"Enter Message : ";
	getline(cin,message);
	cout<<"Enter Key : ";
	getline(cin,key);
	string c=v.encrypt(message,key);
	cout<<"\n\nEncrypted : "<<c<<endl;
	cout<<"\nkey used : "<<v.getKey()<<endl;
	cout<<"\n\n**********************************************************************\n\n"<<endl;
	cout<<"Decryptrd using (this encrypted message nd key): "<<v.decrypt(c,v.getKey())<<"\n\n"<<endl;
	system("pause");
}