using AutoMapper;
using NotJustAGame.Models.DTOs.Characters;

namespace NotJustAGame.Models
{
    public class Mapper : Profile 
    {
        public Mapper()
        {
            //Strucutre: Source to Destination
            CreateMap<Character, CharacterDto>();
            CreateMap<CreateCharacterDto, Character>();
        }
    }
}
