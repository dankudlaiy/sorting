import pandas as pd
import matplotlib.pyplot as plt

file_path = "results.csv"

df = pd.read_csv(file_path)

algorithms = df.columns[1:]

plt.figure(figsize=(12, 8))

for algorithm in algorithms:
    plt.plot(df['size'], df[algorithm], label=algorithm)

plt.title("Comparison of Sorting Algorithms")
plt.xlabel("Array Size")
plt.ylabel("Time Taken")
plt.legend()
plt.grid(True)
plt.savefig('sorting_comparison.png')
plt.show()