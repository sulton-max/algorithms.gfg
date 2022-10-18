namespace gfg_algorithms.Searching
{
    public static class LinearSearch
    {
        public static int Search(int[] array, int value)
        {
            if (array == null || array.Length == 0)
                return -1;

            for (int index = 0; index < array.Length; index++)
                if (array[index] == value)
                    return index;

            return -1;
        }

        public static int SearchRecursively(int[] array, int value, int? index = default)
        {
            if (array == null || array.Length == 0)
                return -1;

            if (!index.HasValue)
                index = array.Length - 1;

            if (index == 0)
                return -1;
            else if (array[index.Value - 1] == value)
                return index.Value - 1;
            else 
                return SearchRecursively(array, value, index - 1);
        }
    }
}
