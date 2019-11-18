using System;
using Tesseract;

namespace OCR_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var testImage = AppDomain.CurrentDomain.BaseDirectory + "test_image\\a.png";
            try
            {
                using (var engine =new TesseractEngine(@"tessdata","eng+chi_sim",EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(testImage))
                    {
                        using (var page = engine.Process(img))
                        {
                            var texto = page.GetText();
                            Console.WriteLine(":{0}", page.GetMeanConfidence());
                            Console.WriteLine("Texto:{0}", texto);
                        }
                            
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
