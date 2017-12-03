namespace Valit
{
    public static class ValitRuleSByteExtensions
    {
        public static IValitRule<TObject, sbyte> IsGreaterThan<TObject>(this IValitRule<TObject, sbyte> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p > value);

        public static IValitRule<TObject, sbyte> IsGreaterThan<TObject>(this IValitRule<TObject, sbyte> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p > value.Value);


        public static IValitRule<TObject, sbyte?> IsGreaterThan<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value > value);

        public static IValitRule<TObject, sbyte?> IsGreaterThan<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value > value.Value);


        public static IValitRule<TObject, sbyte> IsLessThan<TObject>(this IValitRule<TObject, sbyte> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p < value);

        public static IValitRule<TObject, sbyte> IsLessThan<TObject>(this IValitRule<TObject, sbyte> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p < value.Value);


        public static IValitRule<TObject, sbyte?> IsLessThan<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value < value);

        public static IValitRule<TObject, sbyte?> IsLessThan<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value < value.Value);


        public static IValitRule<TObject, sbyte> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p >= value);

        public static IValitRule<TObject, sbyte> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p >= value.Value);


        public static IValitRule<TObject, sbyte?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value >= value);

        public static IValitRule<TObject, sbyte?> IsGreaterThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value >= value.Value);


        public static IValitRule<TObject, sbyte> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p <= value);

        public static IValitRule<TObject, sbyte> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p <= value.Value);


        public static IValitRule<TObject, sbyte?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value <= value);

        public static IValitRule<TObject, sbyte?> IsLessThanOrEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value <= value.Value);


        public static IValitRule<TObject, sbyte> IsEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p == value);

        public static IValitRule<TObject, sbyte> IsEqualTo<TObject>(this IValitRule<TObject, sbyte> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => value.HasValue && p == value.Value);


        public static IValitRule<TObject, sbyte?> IsEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte value) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value == value);

        public static IValitRule<TObject, sbyte?> IsEqualTo<TObject>(this IValitRule<TObject, sbyte?> rule, sbyte? value) where TObject : class
            => rule.Satisfies(p => p.HasValue && value.HasValue && p.Value == value.Value);


        public static IValitRule<TObject, sbyte> IsPositive<TObject>(this IValitRule<TObject, sbyte> rule) where TObject : class
            => rule.Satisfies(p => p > 0);

        public static IValitRule<TObject, sbyte?> IsPositive<TObject>(this IValitRule<TObject, sbyte?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value > 0);

        public static IValitRule<TObject, sbyte> IsNegative<TObject>(this IValitRule<TObject, sbyte> rule) where TObject : class
            => rule.Satisfies(p => p < 0);

        public static IValitRule<TObject, sbyte?> IsNegative<TObject>(this IValitRule<TObject, sbyte?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value < 0);

        public static IValitRule<TObject, sbyte> IsNonZero<TObject>(this IValitRule<TObject, sbyte> rule) where TObject : class
            => rule.Satisfies(p => p != 0);

        public static IValitRule<TObject, sbyte?> IsNonZero<TObject>(this IValitRule<TObject, sbyte?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue && p.Value != 0);

        public static IValitRule<TObject, sbyte?> Required<TObject>(this IValitRule<TObject, sbyte?> rule) where TObject : class
            => rule.Satisfies(p => p.HasValue);
    }
}
