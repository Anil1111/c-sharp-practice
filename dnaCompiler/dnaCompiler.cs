using System;
public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
          List<string> dnaString = new List<string>();

          foreach (char d in dna) {
            if( d.ToString() == "A" ) {
              dnaString.Add("T");
            } else if ( d.ToString() == "T" ) {
              dnaString.Add("A");
            } else if ( d.ToString() == "G" ) {
              dnaString.Add("C"); 
            } else if ( d.ToString() == "C" ) {
              dnaString.Add("G");
            }
          }

          return dna;
        }
    }