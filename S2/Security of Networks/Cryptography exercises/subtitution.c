#include <stdio.h>
#include <stdlib.h>

void  decypher(char str[])
{
    int key = 15;
    char alphabet[26]={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    //printf("%c",str[0]);
    for(int i =0; str[i]!='\0';i++)
    {
        for(int j = 0;alphabet[j]!='\0';j++)
        {
            if (str[i] == ' ')  printf(" ");
            if(str[i]==alphabet[j])
            {
                if (str[i]+key > 'z')
                {
                    printf("%c",alphabet[((j+key)%26)]);   
                }
                else    printf("%c", alphabet[j]+key);
            }
            
        }        
    }
}
int main()
{
// char ch='z'; //ASCII value of 'A' is 65
// printf("%c",++ch); // Now value of ++ch is 66 in integer and 'B' in character
decypher("mlvdrxo");
//if ('j'+18 > 'z')     printf("%c",'j'+18);
return 0;
}