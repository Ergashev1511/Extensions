namespace Extensions;

public static class Extension
{
    public static T[] Remove<T>(this T[] res,  int a)
    {
        T[] arr = new T[res.Length-1];

        for (int i = 0; i <res.Length; i++)
        {
            if (i < (a - 1) )
            {
                 arr[i]=res[i];
            }
            else if (i >(a - 1))
            {
               arr[i-1] = res[i];
            }
           
        }
        return arr;
    }


    public static T[] Add<T>(this T[] res, int a,T t)
    {
        T[] arr = new T[res.Length + 1];
        for (int i = 0; i < res.Length+1; i++)
        {
            if (i < (a - 1))
            {
                arr[i] = res[i];
            }
            else if (i == (a - 1))
            {
                arr[i] = t;
            }
            else if (i > (a - 1))
            {
                arr[i] = res[i+1];
                
            }
        }

        return arr;
    }
}