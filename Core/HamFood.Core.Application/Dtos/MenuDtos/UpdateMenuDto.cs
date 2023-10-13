using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamFood.Core.Application.Dtos.MenuDtos
{
    public class UpdateMenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public decimal MenuPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
