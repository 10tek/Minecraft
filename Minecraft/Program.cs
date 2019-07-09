using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* D = derevo
 * K = kamen
 * J = jelezo
 * Z = zoloto
 * A = almaz
 * O = pustota
 * P = palka
 */

namespace Minecraft
{
    class Program
    {
        const string PICKAXE = "MMMOPOOPO";
        const string SWORD = "OMOOMOOPO";
        const string SHOVEL = "OMOOPOOPO";
        const string AXE = "MMOMPOOPO";
        const string HOE = "MMOOPOOPO";
        const int VERST_POS_X = 70;
        static void Main(string[] args)
        {
            int menu;
            bool isExit = false;
            Console.SetWindowSize(125, 50);
            List<Material> materials = new List<Material>();
            for (int i = 0; i < 9; i++)
            {
                materials.Add(new Material());
            }
            ShowRecept();
            while (!isExit)
            {
                Console.Write("Меню: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out menu) && (menu < 4 && menu > 0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Неккоректный выбор пункта меню! Выберите заново: ");
                    }
                }
                Console.Clear();
                ShowVerst(materials);
                ShowRecept();
                switch (menu)
                {
                    case 0: isExit = true; break;
                    case 1: SetMaterial(materials); break;
                    case 2: Verst(materials); break;
                    case 3: Clear(materials); break;
                }
            }
        }
        static public void Clear(List<Material> materials)
        {
            foreach (var material in materials)
            {
                material.SetMaterial('O');
            }
        }
        static public void Verst(List<Material> materials)
        {
            string instrument = "";
            foreach (var material in materials)
            {
                instrument += material.GetMaterial();
            }
            switch (instrument)
            {
                case "DDDOPOOPO": Console.WriteLine("У вас получилась деревянная кирка!"); break;
                case "KKKOPOOPO": Console.WriteLine("У вас получилась каменная кирка!"); break;
                case "JJJOPOOPO": Console.WriteLine("У вас получилась железная кирка!"); break;
                case "ZZZOPOOPO": Console.WriteLine("У вас получилась золотая кирка!"); break;
                case "AAAOPOOPO": Console.WriteLine("У вас получилась алмазная кирка!"); break;

                case "ODOODOOPO": Console.WriteLine("У вас получилась деревянный меч!"); break;
                case "OKOOKOOPO": Console.WriteLine("У вас получилась каменный меч!"); break;
                case "OJOOJOOPO": Console.WriteLine("У вас получилась железный меч!"); break;
                case "OZOOZOOPO": Console.WriteLine("У вас получилась золотый кмеч!"); break;
                case "OAOOAOOPO": Console.WriteLine("У вас получилась алмазный меч!"); break;

                case "ODOOPOOPO": Console.WriteLine("У вас получилась деревянная лопата!"); break;
                case "OKOOPOOPO": Console.WriteLine("У вас получилась каменная лопата!"); break;
                case "OJOOPOOPO": Console.WriteLine("У вас получилась железная лопата!"); break;
                case "OZOOPOOPO": Console.WriteLine("У вас получилась золотая лопата!"); break;
                case "OAOOPOOPO": Console.WriteLine("У вас получилась алмазная лопата!"); break;

                case "DDODPOOPO": Console.WriteLine("У вас получилась деревянная топор!"); break;
                case "KKOKPOOPO": Console.WriteLine("У вас получилась каменная топор!"); break;
                case "JJOJPOOPO": Console.WriteLine("У вас получилась железная топор!"); break;
                case "ZZOZPOOPO": Console.WriteLine("У вас получилась золотая топор!"); break;
                case "AAOAPOOPO": Console.WriteLine("У вас получилась алмазная топор!"); break;

                case "DDOOPOOPO": Console.WriteLine("У вас получилась деревянная мотыга!"); break;
                case "KKOOPOOPO": Console.WriteLine("У вас получилась каменная мотыга!"); break;
                case "JJOOPOOPO": Console.WriteLine("У вас получилась железная мотыга!"); break;
                case "ZZOOPOOPO": Console.WriteLine("У вас получилась золотая мотыга!"); break;
                case "AAOOPOOPO": Console.WriteLine("У вас получилась алмазная мотыга!"); break;

                default: Console.WriteLine("Не получилось, попробуйте еще"); break;
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            ShowVerst(materials);
            ShowRecept();

        }
        static public void ShowRecept()
        {
            Console.SetCursorPosition(VERST_POS_X, 0);
            Console.WriteLine(" ___ ___ ___ ");
            for (int j = 0; j < 3; j++)
            {
                Console.SetCursorPosition(VERST_POS_X, j * 3 + 3);
                Console.WriteLine(" ___ ___ ___ ");
            }
            for (int i = 0; i < 16; i += 4)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.SetCursorPosition(VERST_POS_X + i, j + 1);
                    Console.WriteLine("|");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(VERST_POS_X + 1 + (j * 4), 1 + (i * 3));
                    Console.WriteLine(i * 3 + j + 1);
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("D = derevo       Меню:\nK = kamen        1 - Добавить материал\nJ = jelezo       2 - Верстка\nZ = zoloto       3 - Очистить\nA = almaz       0 - Выход\nP = palka");
            int yPosition = 10;
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("M - значит материал, которую вы сами можете выбрать.");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("O - значит пустота.");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("Кирка: ");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            for (int i = 0, j = 0; j < 3; j++)
            {
                Console.Write($" {PICKAXE[i++]}  {PICKAXE[i++]}  {PICKAXE[i++]} ");
                Console.SetCursorPosition(VERST_POS_X, yPosition++);
            }
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("Меч: ");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            for (int i = 0, j = 0; j < 3; j++)
            {
                Console.Write($" {SWORD[i++]}  {SWORD[i++]}  {SWORD[i++]} ");
                Console.SetCursorPosition(VERST_POS_X, yPosition++);
            }
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("Лопата: ");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            for (int i = 0, j = 0; j < 3; j++)
            {
                Console.Write($" {SHOVEL[i++]}  {SHOVEL[i++]}  {SHOVEL[i++]} ");
                Console.SetCursorPosition(VERST_POS_X, yPosition++);
            }
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("Топор: ");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            for (int i = 0, j = 0; j < 3; j++)
            {
                Console.Write($" {AXE[i++]}  {AXE[i++]}  {AXE[i++]} ");
                Console.SetCursorPosition(VERST_POS_X, yPosition++);
            }
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            Console.Write("Мотыга: ");
            Console.SetCursorPosition(VERST_POS_X, yPosition++);
            for (int i = 0, j = 0; j < 3; j++)
            {
                Console.Write($" {HOE[i++]}  {HOE[i++]}  {HOE[i++]} ");
                Console.SetCursorPosition(VERST_POS_X, yPosition++);
            }
            Console.SetCursorPosition(0, 6);
        }
        static public void ShowVerst(List<Material> materials)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(VERST_POS_X + 2 + (j * 4), (i * 3 + 2));
                    Console.Write((materials[i * 3 + j].GetMaterial() == "O" ? " " : materials[i * 3 + j].GetMaterial()));
                }
            }
        }
        static public void SetMaterial(List<Material> materials)
        {
            int position;
            char material;
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Что бы добавить материал, сперва выберите позицию (1-9)(int)");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out position) && (position < 9 && position > 0))
                {
                    break;
                }
                else
                {
                    Console.Write("Неккоректный выбор позиции! Выберите заново: ");
                }
            }
            Console.WriteLine("Выберите материал из списка, который хотите добавить(Заглавная буква)");
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out material) && (material == 'P' || material == 'D' || material == 'K' || material == 'J' || material == 'Z' || material == 'A'))
                {
                    break;
                }
                else
                {
                    Console.Write("Неккоректный выбор материала! Выберите заново: ");
                }
            }

            //while (material != 'D' || material != 'K' || material != 'J' || material != 'Z' || material != 'A' || material != 'P')
            //{
            //    Console.WriteLine("Неккоректный материал!");
            //    material = Convert.ToChar(Console.ReadLine());
            //}
            materials[position - 1].SetMaterial(material);
            Console.Clear();
            ShowVerst(materials);
            ShowRecept();
        }
    }
}