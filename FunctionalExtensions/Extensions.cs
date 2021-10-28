using System;

namespace FunctionalExtensions
{
    public static class Extensions
    {
        public static TTo? Map<TFrom, TTo>(this TFrom? input, Func<TFrom, TTo> map) => 
            input is null 
                ? default 
                : map(input);

        public static T? Apply<T>(this T? @this, Action<T> apply)
        {
            if (@this is null) 
                return @this;
            apply(@this);
            return @this;
        }
    }
}
