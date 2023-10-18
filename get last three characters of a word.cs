Console.WriteLine("Please enter string");
string s = Console.ReadLine();
char[] sr1 = s.ToCharArray();
string p = "";
int count = 0;
for (int i = sr1.Length - 1; i >= 0; i--)
{
    if (sr1[i] != ' ')
    {
        count++;
        p = sr1[i] + p;
        
    }
    else { break; }
}
Console.WriteLine("count:" + count);
Console.WriteLine("count:" + p);