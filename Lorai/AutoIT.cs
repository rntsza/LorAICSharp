using System.Windows.Forms;
using AutoItX3Lib;


namespace Lorai
{
    class AutoIT
    {
        AutoItX3 auto = new AutoItX3();
        public void Click(string ClickSide, int x, int y, int manyClick, int Speed)
        {
            auto.WinActivate("Legends of Runeterra");
            auto.MouseClick(ClickSide, x, y, manyClick, Speed);
        }
        /*        public void DragAndDrop(int x, int y, int dropX, int dropY, int Delay)
                {
                    auto.MouseClickDrag("Left", x, y, dropX, dropY, Delay);
                }*/
        /*        public void Allin(int initialX, int initialY)
                {
                    auto.MouseMove(initialX, initialY, -1);
                    auto.MouseDown("Left");
                    auto.MouseMove(2439, 902, 20);
                    auto.MouseMove(2488, 707, 1);
                    auto.MouseMove(2864, 674, 1);
                    auto.MouseUp("Left");
                }*/
        public void Wheel(string UpOrDown, int Length)
        {
            auto.WinActivate("Legends of Runeterra");
            auto.MouseWheel(UpOrDown, Length);
        }
        public void Sleep(int Duration)
        {
            auto.WinActivate("Legends of Runeterra");
            auto.Sleep(Duration);
        }
        /*        public void StartGame(string GameMode, int Deck)
                {
                    switch (GameMode)
                    {
                        case "PvP":
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2222, 262, 1, -1);
                            Sleep(10);
                            //Choise Deck here
                            if (Deck == 1)
                            {
                                auto.MouseClick("Left", 2566, 302, 1, -1);
                            }
                            else if (Deck == 2)
                            {
                                auto.MouseClick("Left", 2908, 292, 1, -1);
                            }
                            else if (Deck == 3)
                            {
                                auto.MouseClick("Left", 3249, 313, 1, -1);
                            }
                            else
                            {
                                auto.MouseClick("Left", 3593, 316, 1, -1);
                            }
                            //Click play
                            //auto.MouseClick("Left", 3548, 982, 1, -1);
                            break;

                        case "PvE":
                            //Choise mode
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2216, 343, 1, -1);
                            Sleep(10);
                            //Choise Deck here
                            if (Deck == 1)
                            {
                                auto.MouseClick("Left", 2566, 302, 1, -1);
                            }
                            else if (Deck == 2)
                            {
                                auto.MouseClick("Left", 2908, 292, 1, -1);
                            }
                            else if (Deck == 3)
                            {
                                auto.MouseClick("Left", 3249, 313, 1, -1);
                            }
                            else
                            {
                                auto.MouseClick("Left", 3593, 316, 1, -1);
                            }
                            Sleep(5);
                            //Click play
                            auto.MouseClick("Left", 3548, 982, 1, -1);
                            break;

                        case "Expeditions":
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2216, 343, 1, -1);
                            //Click play
                            auto.MouseClick("Left", 3095, 837, 1, -1);
                            break;

                        case "Challenges":
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2216, 343, 1, -1);
                            //Choise Challenge here
                            auto.MouseClick("Left", 3553, 954, 1, -1);
                            //Click play
                            auto.MouseClick("Left", 3465, 961, 1, -1);
                            break;

                        case "Gauntlet":
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2216, 343, 1, -1);
                            //Click play
                            auto.MouseClick("Left", 3085, 899, 1, -1);
                            break;

                        case "Labs":
                            auto.MouseClick("Left", 2003, 368, 1, -1);
                            auto.MouseClick("Left", 2216, 343, 1, -1);
                            //Click play
                            auto.MouseClick("Left", 3090, 802, 1, -1);
                            break;

                        default:
                            break;
                    }
                }
                public void ReplaceCards(string One, string Two, string Three, string Four)
                {
                    if(One == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (Two == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (Three == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (Four == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);
                    //auto.MouseClick("Left", 3590, 539, 1, -1);
                }
                public void ReplaceCards(string One, string Two, string Three)
                {
                    if (One == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (One == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (One == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (One == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);

                    if (Two == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (Two == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (Two == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (Two == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);

                    if (Three == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (Three == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (Three == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (Three == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);
                    //auto.MouseClick("Left", 3590, 539, 1, -1);
                }
                public void ReplaceCards(string One, string Two)
                {
                    if (One == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (One == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (One == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (One == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);

                    if (Two == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (Two == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (Two == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (Two == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);

                    //auto.MouseClick("Left", 3590, 539, 1, -1);
                }
                public void ReplaceCards(string One)
                {
                    if (One == 1.ToString())
                        auto.MouseClick("Left", 2452, 541, 1, -1);
                    Sleep(10);
                    if (One == 2.ToString())
                        auto.MouseClick("Left", 2726, 542, 1, -1);
                    Sleep(10);
                    if (One == 3.ToString())
                        auto.MouseClick("Left", 3040, 541, 1, -1);
                    Sleep(10);
                    if (One == 4.ToString())
                        auto.MouseClick("Left", 3310, 554, 1, -1);
                    Sleep(10);
                    //auto.MouseClick("Left", 3590, 539, 1, -1);
                }*/
        /*       public void DontReplaceCards()
                {
                    auto.MouseClick("Left", 3590, 539, 1, -1);
                }*/
        /*       public void Emoji(string Name)
               {
                   auto.MouseClick("Left", 2277, 1031, 1, -1);
                   switch (Name)
                   {
                       case "Shen":
                           auto.MouseClick("Left", 2278, 846, 1, -1);
                           break;
                       case "SadPoro":
                           auto.MouseClick("Left", 2074, 842, 1, -1);
                           break;
                       case "Jinx":
                           auto.MouseClick("Left", 2284, 357, 1, -1);
                           break;
                       case "Darius":
                           auto.MouseClick("Left", 2091, 603, 1, -1);
                           break;
                       case "Heimer":
                           auto.MouseClick("Left", 2303, 590, 1, -1);
                           break;
                       case "Poro":
                           auto.MouseClick("Left", 2072, 372, 1, -1);
                           break;
                       default:
                           break;
                   }
               } */
        public void InputSpaceKey()
        {
            SendKeys.Send(" ");
        }
        /*        public void Surrender()
                {
                    auto.MouseClick("Left", 3766, 52, 1, -1);
                    Sleep(10);
                    //Surrender
                    auto.MouseClick("Left", 2733, 892, 1, -1);
                    Sleep(10);
                    //Ok
                    auto.MouseClick("Left", 3017, 609, 1, -1);
                    Sleep(300);
                    //Click on Continue
                    auto.MouseClick("Left", 3192, 984, 1, -1);
                    //Cancel
                    //auto.MouseClick("Left", 3017, 609, 1, 2);
                }
            }*/
    }
}