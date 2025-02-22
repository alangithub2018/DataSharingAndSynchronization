# Data Sharing and Synchronization in C#

This project demonstrates how to synchronize access to shared resources between multiple threads in C#, using `Interlocked.Add()` to ensure data integrity and prevent race conditions.

## Technologies Used

- [![C#](https://img.shields.io/badge/csharp-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [![.NET](https://img.shields.io/badge/.NET-%2363299E.svg?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/)

## Features

- **Data Sharing:** Access to shared resources by multiple threads.
- **Thread Synchronization:** Use of `Interlocked.Add()` for atomic operations.
- **Race Condition Prevention:** Prevents multiple threads from modifying shared data simultaneously.
- **Data Integrity:** Ensures that shared data remains consistent and valid.

## ️ How to Use

1. Clone the repository:

   ```bash
   git clone <repository_URL>
   ```

2. Open the solution in Visual Studio or your preferred IDE.
3. Run the project.

## Code Examples

### Using Interlocked.Add()

`Interlocked.Add()` performs an atomic addition, meaning the operation completes as a single, indivisible instruction. This is crucial in multithreaded scenarios to prevent other threads from interrupting the operation and causing race conditions.

```csharp
private static int sharedResource = 0;

public static void UpdateSharedResource(int valueToAdd) {
    Interlocked.Add(ref sharedResource, valueToAdd);
    Console.WriteLine($"Shared resource updated to: {sharedResource}");
}
```
