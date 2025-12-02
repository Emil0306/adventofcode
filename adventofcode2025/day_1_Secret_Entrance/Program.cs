class Program{
    static void Main(){
        TextReader? tr = null;
        string currentLine = "";
        bool done = false;
        int pointer = 50;
        int code = 0;
        try {
            tr = new StreamReader(System.IO.File.OpenRead("C:\\github_repo\\adventofcode\\adventofcode2025\\day_1_Secret_Entrance\\input.txt"));
            while (true){
                currentLine = tr.ReadLine();
                if (currentLine == null) break;
                string[] number;
                int oldPointer = pointer;
                switch(currentLine[0])
                {
                    case 'R':
                        number = currentLine.Split("R");
                        pointer += int.Parse(number[1]);
                        if (pointer >= 100)
                        {
                            do
                            {
                                pointer -= 100;
                                code++;
                            } while (pointer >= 100);
                        }
                        break;
                    case 'L':
                        number = currentLine.Split("L");
                        pointer -= int.Parse(number[1]);
                        if (pointer < 0)
                        {
                            do
                            {
                                pointer += 100;
                                code++;
                            } while (pointer < 0);
                        }
                        if (pointer == 0) code++;
                        if (oldPointer == 0) code--;
                        break;
                }
            }
        }
        catch(DirectoryNotFoundException){
            Console.WriteLine("Invalid path");
        }
        catch(UnauthorizedAccessException){
            Console.WriteLine("You dont have acces to the file");
        }
        catch(Exception ex){
            Console.WriteLine("Something went wrong "+ex);
        }
        finally{
            tr?.Close(); // allways close file
        }
        Console.WriteLine("The code is: "+code);
    }
}
