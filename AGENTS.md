```markdown
# AGENTS.md - Coding Agent Guidelines

These guidelines outline the fundamental principles and practices for development of AI coding agents within this repository.  Strict adherence to these principles is crucial for maintaining a maintainable, scalable, and reliable codebase.

## 1. DRY (Don't Repeat Yourself)

*   All functionality, data structures, and algorithms should be encapsulated within individual, well-defined modules and files.
*   Avoid duplication of code.  Refactor and consolidate where possible.
*   Design for extensibility; avoid creating overly specialized components.

## 2. KISS (Keep It Simple, Stupid)

*   Code should be as concise and easy to understand as possible.
*   Prioritize clarity over complex or overly clever solutions.
*   Avoid unnecessary abstractions or layers of complexity.
*   Focus on the core requirements.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module should have one, and only one, reason to change.
*   **Open/Closed Principle:**  The system should be extensible without modifying the existing code. Implement new functionality via new classes/modules, not by modifying existing ones.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Client code should not be forced to depend on methods it does not use.
*   **Dependency Inversion Principle:** High-level modules (e.g., agents) should be dependent on low-level modules (e.g., data structures), but low-level modules should not depend on high-level modules.

## 4. YAGNI (You Aren't Gonna Need It)

*   Implement only the features that are *currently* required.
*   Avoid implementing future requirements – focus on what's needed now.
*   Don't introduce functionality until it's demonstrably necessary.

## 5. Code Style & Structure

*   **Naming Conventions:** Use snake_case for variables and functions.  Follow a consistent naming scheme (e.g., camelCase for module names, camelCase for variables).
*   **Comments:**  Provide concise, informative comments, explaining *why* the code is doing something, not *what* it's doing.  Avoid simply restating the code.
*   **Indentation:**  Use 2 spaces for indentation.
*   **Line Length:**  Maximum 180 lines per file.
*   **Docstrings:** Comprehensive docstrings are required for each module and function explaining their purpose, parameters, and return values.

## 6. Testing

*   All development must be productive.
*   Unit tests should verify individual functions and modules.
*   Focus on testing edge cases and boundary conditions.
*   Use a testing framework (e.g., `pytest`) for comprehensive testing.
*   Mocking is restricted to external tests only.

## 7. File Limits

*   Each file should have a maximum of 180 lines of code.
*   Code must be self-contained and complete.
*   Avoid importing unnecessary external libraries.

## 8.  Data Structures & Algorithms

*   Use appropriate data structures for efficient operations.
*   Optimize algorithms for performance.
*   Consider time and space complexity when designing solutions.

## 9.  Error Handling & Logging

*   Implement robust error handling to gracefully handle unexpected situations.
*   Use logging to record errors, warnings, and debugging information.
*   Avoid exposing sensitive information in logs.

## 10.  Configuration Management (Future Consideration)**

*   Consider a mechanism for managing configuration (e.g., YAML or JSON) to facilitate easy adaptation.  This is outside the immediate scope of initial implementation but should be considered.


These guidelines are a starting point.  They will be reviewed and updated as the project evolves.
```