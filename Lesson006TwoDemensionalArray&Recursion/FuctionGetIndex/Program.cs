int GetIndex(int currentIndex, int length)
{
    if (currentIndex + 1 >= length)
    {
        currentIndex = 0;
    }
    return currentIndex;
}
