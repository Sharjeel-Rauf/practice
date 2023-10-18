Console.WriteLine("Please enter string");
string s=Console.ReadLine();
char[] sr1 = s.ToCharArray();
int count = 0;
for(int i = 0; i < sr1.Length-1; i--)
{
    if (sr1[i] == ' ')
    {
        count++;
        continue;
    }
    else
    {
        break;
    }
}
Console.WriteLine("count:" + count);
