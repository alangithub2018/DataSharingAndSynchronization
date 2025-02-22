# Data Sharing and Synchronization in C# with lock()

This project demonstrates how to use `lock()` in C# to synchronize access to shared resources between multiple threads, preventing race conditions and ensuring data integrity.

## Technologies Used

- [![C#](https://img.shields.io/badge/csharp-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [![.NET](https://img.shields.io/badge/.NET-%2363299E.svg?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/)

## Features

- **Data Sharing:** Access to shared resources by multiple threads.
- **Thread Synchronization:** Use of `lock()` to guarantee exclusive access to critical sections.
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

### Using lock()

```csharp
private static readonly object lockObject = new object();
private static int sharedResource = 0;

public static void UpdateSharedResource() {
    lock (lockObject) {
        // Critical section: exclusive access guaranteed
        sharedResource++;
        Console.WriteLine($"Shared resource updated to: {sharedResource}");
    }
}
