using System;

namespace _01_Prototype
{
    class CalendarProptotype : IClonable<CalendarProptotype>
    {
        public virtual CalendarProptotype Clone()
        {
            var copyOfPrototype = (CalendarProptotype)MemberwiseClone();
            return copyOfPrototype;
        }

        object ICloneable.Clone()
        {
            return (this as IClonable<CalendarProptotype>).Clone();
        }
    }
}
