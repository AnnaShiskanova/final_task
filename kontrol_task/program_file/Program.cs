
    System.Console.WriteLine("Введите количество элементов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arr[i] = element;
        
    }
    foreach (var item in arr) 
        Console.Write($"{item}, ");
    System.Console.WriteLine();

    string[] resultArray = new string[arr.Length];
    void ResultArray(string[] arr, string[] resultArray)
    {
        int j = 0;
        // foreach (var el in arr)
        // {
        //     if (el.Length <= max)
        //     Console.Write($"{el}, ");
        // }
       
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
                {
                   resultArray[j] = arr[i];
                    j++;
                }

            
        }

        
    }
    ResultArray(arr, resultArray);
   
   PrintArray(resultArray);

   void PrintArray(string[] array)
    {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine();
    }




