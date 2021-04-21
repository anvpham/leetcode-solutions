public class Solution
{
   public void DuplicateZeros(int[] arr)
   {
      for (int i = 0; i < arr.Length; i++)
      {
         if (arr[i] == 0)
         {
            DuplicateAt(i, arr);
            i++;
         }
      }
   }

   public void DuplicateAt(int position, int[] arr)
   {
      for (int i = arr.Length - 1; i > position; i--)
      {
         arr[i] = arr[i - 1];
      }
   }
}