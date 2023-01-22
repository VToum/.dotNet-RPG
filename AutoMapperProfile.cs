using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _dotNet_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}