namespace TowersOfHanoi.lib{

    public interface ITowersOfHanoi{

        public void Restart(int Amount);
        
        public (int, int) MoveNext();
        
        public (int, int, int) CountDiscs();
        
        public int Moves {get;}
        
       }
}