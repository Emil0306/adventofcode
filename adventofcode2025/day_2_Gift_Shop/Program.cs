class Program
{
    private TextReader? tr;
    private string[] input = new string[]{};

    public Program(string path)
    {
        try
        {
            tr = new StreamReader(File.OpenRead(path));
            input = tr.ReadToEnd().Split(",");
        }
        catch(DirectoryNotFoundException){
            Console.WriteLine("Invalid path");
        }
        catch(UnauthorizedAccessException){
            Console.WriteLine("You dont have acces to the file");
        }
        catch(Exception ex){
            Console.WriteLine("Something went wrong: "+ex);
        }
        finally{
            tr?.Close();
        }
        
        
    }
    
    static void Main(string[] args)
    {
        Program p = new Program("C:\\github_repo\\adventofcode\\adventofcode2025\\day_2_Gift_Shop\\testinput.txt");

        foreach (string idRange in p.input)
        {
            int startID = int.Parse(idRange.Split('-')[0]);
            int endID = int.Parse(idRange.Split('-')[1]);
            for (int i = 0; startID <= endID; i++)
            {
                // split number in two :)))
                if (startID.ToString()[0] == startID.ToString()[1])
                {

                }
                startID++;
            }
        }
    }
}
