namespace NotJustAGame.ModelDTOs.Characters
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Sim";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int IQ { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
