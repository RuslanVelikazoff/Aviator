namespace SaveData
{
    [System.Serializable]
    public class GameData
    {
        public bool[] airplanesOpen = new bool[6];
        public bool[] mapsOpen = new bool[5];

        public bool[] airplanesBuy = new bool[6];
        public bool[] mapsBuy = new bool[5];

        public GameData()
        {
            //TODO: delete this

            for (int i = 0; i < airplanesOpen.Length; i++)
            {
                airplanesOpen[i] = true;
                airplanesBuy[i] = true;
            }
            for (int i = 0; i < mapsBuy.Length; i++)
            {
                mapsBuy[i] = true;
                mapsOpen[i] = true;
            }

            /*airplanesOpen[0] = true;
            mapsOpen[0] = true;

            airplanesBuy[0] = true;
            mapsBuy[0] = true;*/
        }
    }
}
