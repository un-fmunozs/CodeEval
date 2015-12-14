using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
			Console.WriteLine(longWord(line));
			
            
        }
    }
    
	
	public static string longWord(string s) {
			string[] w = s.Split(new char[]{' '});
			int maxl = 0;
			string res = "";
			foreach (string word in w) {
				if (word.Length > maxl) {
					maxl = word.Length;
					res = word;
				}
			}
			
			return res.Trim();
		}	
	
	
}