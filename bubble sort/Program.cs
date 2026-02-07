
    using System;
class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) //• Burada yeni dəyişən yaradılır: . i
                                        //• 	 → int tam ədəd tipindədir. 
                                        //• 	 → i = 0 dövr başlayanda i sıfırdan başlayır. Yəni ilk addımda olur. i=0
                                        //• 	 → i < n - 1 dövrün davam etməsi üçün şərt qoyulur. Yəni i < n - 1 dən kiçik olduğu müddətcə dövr işləyəcək.
                                        //•   	Bu, dövrün şərtidir.  n → massivdəki elementlərin sayı().- (arr.Length).
                                        //• 	 → n-1 sonuncu elementə qədər dövr etməyi göstərir.
                                        //• 	 → i < n -1 dövr yalnız i bu şərti ödəyənə qədər işləyəcək.Yəni i sonuncu elementə çatanda dövr dayanır. 	
                                        //      i++ Bu, hər dövrün sonunda i-ni 1 vahid artırır.
                                        // Əgər əvvəl i = 0 idisə, növbəti addımda i = 1 olur, sonra i = 2, və s.


        {
            for (int j = 0; j < n - i - 1; j++) //“j dəyişəni yan-yana elementləri yoxlamaq üçündür.”
                                                //• 	“n - i - 1 yazmağımızın səbəbi odur ki, hər dövrün sonunda ən böyük element sona gedir, ona görə onu bir daha yoxlamağa ehtiyac yoxdur.”
                                                //• 	“Beləliklə, Bubble Sort həm xarici dövr(i) ilə neçə dəfə təkrar edəcəyini, həm də daxili dövr(j) ilə hansı elementləri müqayisə edəcəyini idarə edir.”
                                                // qisaca desek • 	“i dövrü neçə dəfə bütün massivdən keçəcəyimizi göstərir.”
                                                //• 	“j dövrü isə hər dəfə yan-yana elementləri müqayisə edir.”
            {
                if (arr[j] > arr[j + 1])
                {
                    // temp adli muveqqeti deyisen yaradilir ve arr[j] deyerini ona menimsedirik. Bu, arr[j] deyerini saxlayir.
                    int temp = arr[j];
                    arr[j] = arr[j + 1];  //   J ci elementin yerinə J+1 ci elementi qoyuruq.
                                          // 	Yəni: “sol elementin yerinə sağdakı elementi yaz.”
                    arr[j + 1] = temp;
                    // arr[j] deyerini arr[j + 1] deyerine menimsedirik. Bu, arr[j] deyerini arr[j + 1] deyerine deyisdirir.
                    //Sağdakı elementin yerinə müvəqqəti saxladığımız(temp) dəyəri qoyuruq.
                    //Yəni: “sağ elementin yerinə əvvəlki sol elementi yaz.”
                    //yeni qisacasi “temp sadəcə müvəqqəti saxlama yeridir. İki elementin yerini dəyişmək üçün birini qutuda saxlayırıq, sonra yerlərini dəyişirik.”
                }
            }
        }
    }

    static void Main()
    {

        int[] arr = { 5, 1, 4, 2, 8 };
        BubbleSort(arr);
        Console.WriteLine("cesidlenmish massiv: " + string.Join(", ", arr));
    }
}






