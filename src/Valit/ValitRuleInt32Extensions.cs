namespace Valit
{
    public static class ValitRuleInt32Extensions
    {
        public static IValitRule<TObject, int> IsGreaterThan<TObject>(this IValitRule<TObject, int> rule, int value) where TObject : class
            => rule.Satisfies(p => p > value);

        public static IValitRule<TObject, int> IsGreaterThan<TObject>(this IValitRule<TObject, int> rule, int? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p > value.Value);

        public static IValitRule<TObject, int?> IsGreaterThan<TObject>(this IValitRule<TObject, int?> rule, int value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value > value);

        public static IValitRule<TObject, int?> IsGreaterThan<TObject>(this IValitRule<TObject, int?> rule, int? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value > value.Value);

        public static IValitRule<TObject, int> IsLessThan<TObject>(this IValitRule<TObject, int> rule, int value) where TObject : class
            => rule.Satisfies(p => p < value);

        public static IValitRule<TObject, int> IsLessThan<TObject>(this IValitRule<TObject, int> rule, int? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p < value.Value);

        public static IValitRule<TObject, int?> IsLessThan<TObject>(this IValitRule<TObject, int?> rule, int value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value < value);

        public static IValitRule<TObject, int?> IsLessThan<TObject>(this IValitRule<TObject, int?> rule, int? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value < value.Value);

        public static IValitRule<TObject, int> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, int> rule, int value) where TObject : class
            => rule.Satisfies(p => p >= value);

        public static IValitRule<TObject, int> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, int> rule, int? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p >= value.Value);

        public static IValitRule<TObject, int?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, int?> rule, int value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value >= value);

        public static IValitRule<TObject, int?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, int?> rule, int? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value >= value.Value);

        public static IValitRule<TObject, int> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, int> rule, int value) where TObject : class
            => rule.Satisfies(p => p <= value);

        public static IValitRule<TObject, int> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, int> rule, int? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p <= value.Value);

        public static IValitRule<TObject, int?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, int?> rule, int value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value <= value);

        public static IValitRule<TObject, int?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, int?> rule, int? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value <= value.Value);

        public static IValitRule<TObject, int> IsEqualTo<TObject>(this IValitRule<TObject, int> rule, int value) where TObject : class
            => rule.Satisfies(p => p == value);

        public static IValitRule<TObject, int> IsEqualTo<TObject>(this IValitRule<TObject, int> rule, int? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p == value.Value);

        public static IValitRule<TObject, int?> IsEqualTo<TObject>(this IValitRule<TObject, int?> rule, int value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value == value);

        public static IValitRule<TObject, int?> IsEqualTo<TObject>(this IValitRule<TObject, int?> rule, int? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value == value.Value);

        public static IValitRule<TObject, int> IsPositive<TObject>(this IValitRule<TObject, int> rule) where TObject : class
            => rule.Satisfies(p => p > 0);

        public static IValitRule<TObject, int?> IsPositive<TObject>(this IValitRule<TObject, int?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value > 0);

        public static IValitRule<TObject, int> IsNegative<TObject>(this IValitRule<TObject, int> rule) where TObject : class
            => rule.Satisfies(p => p < 0);

        public static IValitRule<TObject, int?> IsNegative<TObject>(this IValitRule<TObject, int?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value < 0);

        public static IValitRule<TObject, int> IsNonZero<TObject>(this IValitRule<TObject, int> rule) where TObject : class
            => rule.Satisfies(p => p != 0);

        public static IValitRule<TObject, int?> IsNonZero<TObject>(this IValitRule<TObject, int?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value != 0);

        public static IValitRule<TObject, int?> Required<TObject>(this IValitRule<TObject, int?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue);
    }
}