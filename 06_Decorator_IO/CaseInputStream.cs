using System;
using System.IO;

namespace _06_Decorator_IO
{
    public abstract class CaseInputStream : FileSystemInfo
    {
        protected FileSystemInfo Info { get; }

        protected CaseInputStream(FileSystemInfo info)
        {
            Info = info;
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override string Name { get; }
        public override bool Exists { get; }
    }

    public class LoweCaseInputStream : CaseInputStream
    {
        public LoweCaseInputStream(FileSystemInfo info) : base(info) { }
        public override string FullName => Info.FullName.ToLower();
    }

    public class UpperCaseInputStream : CaseInputStream
    {
        public UpperCaseInputStream(FileSystemInfo info) : base(info) { }
        public override string FullName => Info.FullName.ToUpper();
    }

}
