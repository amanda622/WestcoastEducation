# Westcoast Education

A .NET console application for managing courses, students and staff at Westcoast Education.

## How to run

```bash
cd WestcoastEducation
dotnet run
```

Run the command from the `WestcoastEducation` folder, so the program can find `Data/courses.json`.

## Project structure

| Folder | Content |
|---|---|
| `Models/` | Domain classes: `Course`, `Person`, `Student`, `Teacher`, `EducationLeader`, `Administrator`, `Address`, `School` |
| `Enums/` | `CourseType` (Klassrum / Distans) |
| `Interfaces/` | `IStorage<T>`, `IHasId` |
| `Persistance/` | `Storage<T>` – reads and writes JSON |
| `Data/` | `courses.json` |

## Class design

### Inheritance

```
Person
├── Student
└── Teacher
    └── EducationLeader
        └── Administrator
```

Common data (name, personal number, contact details, address) lives in `Person`. Each subclass only adds what is new, for example `KnowledgeArea` in `Teacher` and `EmploymentDate` in `EducationLeader`. Subclasses reuse the parent's `ToString()` via `base.ToString()`.

### Associations

- **Composition:** `Person` → `Address`. An address belongs to one person and has no meaning on its own.
- **Aggregation:** `Teacher` → `List<Course>` and `School` → lists of courses, students and teachers. A course exists independently and can be moved to another teacher.

### Interfaces

- `IStorage<T>`: a contract for reading and writing data. The program depends on the interface, so the JSON storage could be replaced (e.g. by a database) without changing the calling code.
- `IHasId`: gives `Course` and `Person` a common `Id`. This lets `School` use one generic `AddItem<T>` method to check for duplicates, instead of repeating the same logic for courses, students and teachers.

### Course type

`CourseType` is an enum (`Klassrum`, `Distans`), so a course can only have one of the two valid values.

## Features

- Add and list courses, students and teachers (education leaders and administrators are added as teachers through inheritance)
- Duplicate check by course number / personal number
- Assign courses to a teacher
- Save courses to and load courses from `Data/courses.json`

## Assumptions

- `EndDate` is calculated from `StartDate` + `LengthInWeeks`, so the dates can never contradict each other.
