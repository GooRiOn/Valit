using System;

namespace Valit
{
    public static class ValitRuleDateTimeExtensions
    {
        public static IValitRule<TObject, DateTime> IsAfter<TObject>(this IValitRule<TObject, DateTime> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p > datetime);

        public static IValitRule<TObject, DateTime> IsAfter<TObject>(this IValitRule<TObject, DateTime> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => datetime.HasValue && p > datetime.Value);

        public static IValitRule<TObject, DateTime?> IsAfter<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value > datetime);

        public static IValitRule<TObject, DateTime?> IsAfter<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && datetime.HasValue && p.Value > datetime.Value);

        public static IValitRule<TObject, DateTime> IsBefore<TObject>(this IValitRule<TObject, DateTime> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p < datetime);

        public static IValitRule<TObject, DateTime> IsBefore<TObject>(this IValitRule<TObject, DateTime> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => datetime.HasValue && p < datetime.Value);

        public static IValitRule<TObject, DateTime?> IsBefore<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value < datetime);

        public static IValitRule<TObject, DateTime?> IsBefore<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && datetime.HasValue && p.Value < datetime.Value);

        public static IValitRule<TObject, DateTime> IsAfterOrSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p >= datetime);

        public static IValitRule<TObject, DateTime> IsAfterOrSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => datetime.HasValue && p >= datetime.Value);

        public static IValitRule<TObject, DateTime?> IsAfterOrSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value >= datetime);

        public static IValitRule<TObject, DateTime?> IsAfterOrSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && datetime.HasValue && p.Value >= datetime.Value);

        public static IValitRule<TObject, DateTime> IsBeforeOrSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p <= datetime);

        public static IValitRule<TObject, DateTime> IsBeforeOrSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => datetime.HasValue && p <= datetime.Value);

        public static IValitRule<TObject, DateTime?> IsBeforeOrSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value <= datetime);

        public static IValitRule<TObject, DateTime?> IsBeforeOrSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && datetime.HasValue && p.Value <= datetime.Value);

        public static IValitRule<TObject, DateTime> IsAfterNow<TObject>(this IValitRule<TObject, DateTime> rule) where TObject : class
             => rule.Satisfies(p => p > DateTime.Now);

        public static IValitRule<TObject, DateTime?> IsAfterNow<TObject>(this IValitRule<TObject, DateTime?> rule) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value > DateTime.Now);

        public static IValitRule<TObject, DateTime> IsBeforeNow<TObject>(this IValitRule<TObject, DateTime> rule) where TObject : class
             => rule.Satisfies(p => p < DateTime.Now);

        public static IValitRule<TObject, DateTime?> IsBeforeNow<TObject>(this IValitRule<TObject, DateTime?> rule) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value < DateTime.Now);

        public static IValitRule<TObject, DateTime> IsAfterUtcNow<TObject>(this IValitRule<TObject, DateTime> rule) where TObject : class
             => rule.Satisfies(p => p > DateTime.UtcNow);

        public static IValitRule<TObject, DateTime?> IsAfterUtcNow<TObject>(this IValitRule<TObject, DateTime?> rule) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value > DateTime.UtcNow);

        public static IValitRule<TObject, DateTime> IsBeforeUtcNow<TObject>(this IValitRule<TObject, DateTime> rule) where TObject : class
             => rule.Satisfies(p => p < DateTime.UtcNow);

        public static IValitRule<TObject, DateTime?> IsBeforeUtcNow<TObject>(this IValitRule<TObject, DateTime?> rule) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value < DateTime.UtcNow);

        public static IValitRule<TObject, DateTime> IsSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p == datetime);

        public static IValitRule<TObject, DateTime> IsSameAs<TObject>(this IValitRule<TObject, DateTime> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => datetime.HasValue && p == datetime.Value);

        public static IValitRule<TObject, DateTime?> IsSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && p.Value == datetime);

        public static IValitRule<TObject, DateTime?> IsSameAs<TObject>(this IValitRule<TObject, DateTime?> rule, DateTime? datetime) where TObject : class
             => rule.Satisfies(p => p.HasValue && datetime.HasValue && p.Value == datetime.Value);

        public static IValitRule<TObject, DateTime?> Required<TObject>(this IValitRule<TObject, DateTime?> rule) where TObject : class
             => rule.Satisfies(p => p.HasValue);
    }
}