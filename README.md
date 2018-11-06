# Quiz: Plot DOT

> Data file can be found in the folder `data`.

## Instruction

1. Replace the string value of `FullPathToDataFile` in `Program.cs` with the actual path to data file.
2. Write a static method `FindMean` to find the average from the provided array of int. The function signature should look like the following

    ```
    static int FindMean(int[] values)
    ```

3. Use the method `ReadValuesFromDataFile` of the `ValuesReader` to read the value from the file specified in `FullPathToDataFile`.
4. Implement the loop to plot values as shown in the sample below.
    * Use `*` to plot the actual value
    * Use `-` to plot the mean value return from the method `FindMean()`.

```
PS R:\quiz-plot\DotPlot> dotnet run
DOT Plot

  10 |
   9 |              *****
   8 |       *                      *
   7 |    * *            ****
   6 |             *             * * *
   5 |
   4 |------------------------*---------------
   3 |   *                        *    **** **
   2 |***  *                 * **     *
   1 |            *                        *
   0 |        ****
==============================================
```