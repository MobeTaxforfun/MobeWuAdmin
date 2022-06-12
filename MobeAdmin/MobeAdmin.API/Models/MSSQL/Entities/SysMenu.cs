using System;
using System.Collections.Generic;

namespace MobeAdmin.API.Models.MSSQL.Entities
{
    public partial class SysMenu
    {
        public int Id { get; set; }
        public bool BaseIsDelete { get; set; }
        public DateTime BaseCreateTime { get; set; }
        public DateTime BaseModifyTime { get; set; }
        public int BaseCreatorId { get; set; }
        public int BaseModifierId { get; set; }
        public int BaseVersion { get; set; }
        public int ParentId { get; set; }
        public string MenuName { get; set; } = null!;
        public string MenuIcon { get; set; } = null!;
        public string MenuUrl { get; set; } = null!;
        public int MenuSort { get; set; }
        public string MenuMemo { get; set; } = null!;
    }
}
