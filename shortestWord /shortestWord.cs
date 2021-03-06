public class Kata
{
  public static int FindShort(string s)
  {
    // split string by words (aka spaces)
    string[] words = s.Split(" ");
    // make a variable to store the length
    int shortest = words[0].Length;
    // iterate over the words and store the shortest value
    for( int i = 1; i < words.Length; i++ ) {
      if ( shortest > words[i].Length ) {
        shortest = words[i].Length;
      }
    }

    return shortest;
  }
}