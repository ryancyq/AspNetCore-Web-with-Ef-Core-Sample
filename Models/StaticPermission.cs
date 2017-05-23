using System;

namespace ContosoUniversity.Models
{
    [Flags]
    public enum StaticPermission : long
    {
        NONE = 0x01,
        READ_ONLY = 0x02,
        READ_WRITE = 0x400000000 // 36 bits
    }

    public static class StaticPermissionExtensions
    {
        public const StaticPermission FULL_ACCESS_ALL = StaticPermission.READ_ONLY | StaticPermission.READ_WRITE;
    }
}
