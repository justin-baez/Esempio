namespace BlaisePascal.Esempio.Domain
{
    /// <summary>
    ///
    /// </summary>
    public class Enemy
    {
        // private: modifier that indicates that the variable is only accessible within the class Enemy
        // int: data type that indicates that the variable is an int
        // _heatlh: name of the attribute that represents the health of the enemy
        private int health;

        //constant attributes
        private const int MaxHealth = 100; //constant attribute that represents the maximum health of the enemy

        //public contructor that initializes an object Enemy with starting health
        public Enemy() { }
    }

}
