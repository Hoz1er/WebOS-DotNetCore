using Hoz1er.WebOS.Model.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoz1er.WebOS.Model
{
    public class Hoz1erDBContext:DbContext
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public Hoz1erDBContext(DbContextOptions<Hoz1erDBContext> options)
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
            : base(options)
        { }

        #region 表
        public DbSet<User> User { get; set; }
        #endregion


    }
}
