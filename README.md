# Review Tracker

A simple, minimalist desktop application designed to help you consistently review study materials using a spaced repetition-inspired approach.

<!-- 
    TIP: Take a screenshot of your application and save it in your project folder. 
    Then, replace 'assets/screenshot.png' with the actual path to your image.
-->
<img width="719" height="623" alt="image" src="https://github.com/user-attachments/assets/6f35b6cd-b2ed-4e15-bc41-1899154b7d48" />

## The Problem It Solves

In the age of information, we are constantly consuming new content—PDFs, articles, books, and online courses. The real challenge isn't learning something new, but retaining it. Spaced repetition is a proven technique for this, but it requires a system.

This application was born out of a simple need: to have a quick, no-fuss way to list all the materials I'm studying and immediately see which one I've neglected the most. It answers the daily question: **"What should I review today?"**

## Core Features

-   **Add Items Effortlessly:** Quickly add the name of any study material (PDF, book chapter, video course, etc.) to your review list.
-   **Track Review Counts:** Every item has a counter that tracks how many times you've reviewed it.
-   **One-Click Updates:** Finished a review session? Just click the `+1` button to increment the counter.
-   **Automatic Prioritization:** The list is **always sorted** to show items with the fewest reviews at the top, ensuring you focus your energy where it's needed most.
-   **Persistent Local Storage:** Your list is automatically saved to a `json` file on your computer, so you'll never lose your progress.

## How It Works

The application is built with simplicity in mind, both for the user and in its technical design.

-   **Technology Stack:** C# and Windows Forms (.NET).
-   **Data Storage:** All data is stored in a single, human-readable `review_data.json` file.
-   **File Location:** The data file is located in a dedicated folder in your user documents: `My Documents\ReviewTrackerApp\`. This ensures your data is safe and independent of the application's location.

## Getting Started

There are two ways to get the application running, depending on your needs.

### For Users

1.  Navigate to the `bin/Release` folder in the project directory.
2.  (Recommended) Copy the entire `Release` folder to a convenient location on your computer (e.g., your Desktop).
3.  Double-click the `ReviewTracker.exe` file to run the application.

*For the best experience, create a shortcut to the `.exe` file on your Desktop or pin it to your Start Menu.*

### For Developers

If you want to modify or build the project from the source code:

1.  **Prerequisites:**
    -   [.NET SDK](https://dotnet.microsoft.com/download) (version matching the project)
    -   Visual Studio 2019 or later
2.  **Clone the repository:**
    ```bash
    git clone https://your-repository-url/ReviewTracker.git
    ```
3.  **Open the solution:**
    -   Navigate to the cloned directory.
    -   Open the `ReviewTracker.sln` file in Visual Studio.
4.  **Build the project:**
    -   Press `Ctrl+Shift+B` or go to `Build > Build Solution`.
5.  **Run the application:**
    -   Press `F5` to start debugging, or `Ctrl+F5` to run without debugging.

## How to Use

The workflow is designed to be as simple as possible:

1.  **Launch** the application. Your list of items will be loaded and sorted automatically.
2.  **Add a new item** by typing its name in the text box at the top and clicking the `Add Item` button.
3.  **Identify what to review:** The item at the very top of the list is the one you've reviewed the least. Start with that one!
4.  **After reviewing** the material, find it in the list and click the **`+1`** button next to it.
5.  The list will instantly re-sort itself, and your work is done. Close the app at any time; your progress is saved.

## Future Roadmap

This tool is functional, but there's always room for improvement. Potential future features include:

-   [ ] **Categories/Tags:** Group items by subject (e.g., "Programming," "History," "Work").
-   [ ] **Detailed View:** Ability to add notes, links, or file paths to each item.
-   [ ] **Custom Sort Options:** Allow sorting by name or date added.
-   [ ] **Import/Export:** Back up your list to a CSV or import items in bulk.
-   [ ] **UI Themes:** A dark mode option.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE.md) file for details.
