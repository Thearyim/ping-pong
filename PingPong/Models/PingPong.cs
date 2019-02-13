namespace PingPong
{
    public class PingPong
    {   
        public string[] GetPingPongGame(int number)
        {   
            //A user enters a number, and it then provided a lit of all the
            //numbers beginning at 1, counting up to thir provided number.
            //Except some numbers in this list are replaced with words:
            //-Numbers divisible by 3 are replaced by "ping"
            //-Numbers divisible by 5 are replaced by "pong"
            //-Numbers divisible by both 3 and 5 are replaced by "ping-pong"

            string[] input = new string[number];

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    input[i-1] = "ping-pong";
                } 
                else if (i % 3 == 0)
                {
                    input[i-1] = "ping";
                }
                else if (i % 5 == 0)
                {
                    input[i-1] = "pong";
                }
                else 
                {
                    input[i-1] = i.ToString();
                }
            }

            return input;
            
        }
    }
}