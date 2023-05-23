using WebAPI1.Models.Dto;

namespace WebAPI1.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{ Id= 1, Name="Villa 1"},
                new VillaDTO{ Id= 2, Name="Villa 2"},
            };
    }
}
