//CountSheep(10);
//System.Console.Write("Let's convert whatever you want into an array of characters! ");
//System.Console.WriteLine(MakeItLookLikeAnArray(StringToLetters(Console.ReadLine())));

//System.Console.WriteLine(IsPerfectSquare(26));


System.Console.WriteLine(Senticify("This is an amazing day".Split()));

static string MakeItLookLikeAnArray(char[] letters)
{
    string output = "{";

    for (int i = 0; i < letters.Length; i++)
    {
        if(i != (letters.Length-1))
        {
            output += $"'{letters[i]}',";
        }
        else
        {
            output += $"'{letters[i]}'}}";
        }
        
    }

    return output;

}
static void CountSheep(int sheep)
{
    string saying = "";

    //Non negative number handled
    if(sheep > 0)
    {
        for(int i = 1; i <= sheep; i++)
        {
            System.Console.Write($"{i} sheep... ");
           //saying += $"{i} sheep... " ;
        }

        //System.Console.WriteLine(saying);
    }
    
    
}

static char[] StringToLetters(string someString)
{
    char[] letters = new char[someString.Length];

    for(int i = 0; i < someString.Length; i++)
    {
        letters[i] = someString[i];
    }

    return letters;

}

//Bad Forumula
/*static bool PerfectSquare(int num)
{   /// 4
    /// 64 == 64

    /// 3
    ///9 + 18 + 
    ///(a + b)^2 = (a^2 + 2ab + b^2)
    return Math.Pow(num + num, 2) == (Math.Pow(num, 2) + (2 * num * num) + Math.Pow(num, 2));
}*/

static bool IsPerfectSquare(int x)
{
    int root = (int)Math.Sqrt(x);

    return (int)Math.Pow(root, 2) == x;
}


static bool perfectSquare(int x)
{
    double result = Math.Sqrt(x);
    bool numOut;
    if ( numOut = result % 1 == 0)
    {
        return true;
    }
        
    else 
    {
        return false;
    }
}

static string Senticify(string[] wordArray)
{
    string result = wordArray[0];    //string result = wordArray[0];

    for (int i = 1; i < wordArray.Length; i++)
    {
        result += " " + wordArray[i];
    }

    result += ".";
  
    result = char.ToUpper(result[0]) + result.Substring(1);
    return result;
}

static bool XO(string xo)
{
    int countX = 0;
    int countO = 0;

    foreach(char letter in xo)
    {
        if(letter == 'x' || letter == 'X')
        {
            countX++;
        }
        else if(letter == 'o' || letter == 'O')
        {
            countO++;
        }

        
    }

    return countO == countX;

    /*for(int c = 0; c < xo.Length; c++)
    {
        if(xo[c] == 'x' || xo[c] == 'X')
        {
            countX++;
        }
        else if(xo[c] == 'o' || xo[c] == 'O')
        {
            countO++;
        }

        if(countO == countX)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/
}


static bool InOrder(int[] numbers)
{
    if(numbers.Length > 2)
    {
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i-1] > numbers[i])
            {
                return false;
            }
            
        }
    }

    return true;
}
