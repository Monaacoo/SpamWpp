using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;


namespace EnviarMensagemWpp
{
    internal class program
    {
        static void Mai(string[] args)
        {
            string mensagem = "";
            int quantidadeMensagem = 0;
            itn contador = 10;

            var inputSimulator = new InputSimulator();

            Console.WhriteLine("qual a sua mensagem?");
            mensagem = Console.ReadLine();

            Console.WhriteLine("Quantas vezes?");
            quantidadeMensagem = Convert.Toint32(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WhriteLine("--------->" + (contador - i));
                Thread.Sleep(1000);
            }
            Console.WhriteLine("Enviando!");

            for (int i = 0; i < quantidadeMensagem; i++)
            {
                inputSimulator.Keyboard.TextEntry(mensagem);
                inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(250);

                Console.WhriteLine("Mensagem Enviada")
            }
        }
    }    
}