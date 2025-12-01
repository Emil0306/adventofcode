class Program{
    static void Main(){
        TextReader? tr = null;
        string currentLine = "";
        bool done = false;
        int pointer = 50;
        int code = 0;
        try {
            tr = new StreamReader(System.IO.File.OpenRead("input.txt"));
            while (!done){
                currentLine = tr.ReadLine();
                string[] number;
                switch(currentLine[0])
                {
                    case 'R':
                        number = currentLine.Split("R");
                        pointer += int.Parse(number[1]);
                        if (pointer % 100 == 0){
                            code++;
                        }
                        break;
                    case 'L':
                        number = currentLine.Split("L");
                        pointer -= int.Parse(number[1]);
                        if (pointer % 100 == 0){
                            code++;
                        }
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
        catch (System.NullReferenceException){ // Done with file
            Console.WriteLine("The code is: "+code);
        }
        catch(Exception ex){
            Console.WriteLine("Something went wrong "+ex);
        }
        finally{
            tr?.Close(); // allways close file
        }
    }
}
