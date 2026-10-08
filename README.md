# Baobab Ridge Wildlife Rehabilitation Centre
> **PRG2782 Group Project**

---

## Project Overview
The **Baobab Ridge Wildlife Rehabilitation Centre** application is a Windows Forms desktop application developed in C#. The purpose of the system is to assist a wildlife rehabilitation centre with managing animal records throughout the rehabilitation process.

### Key Capabilities
- **Add new animal records** with data validation
- **View all animal records** in a structured grid view
- **Search for animals** by their unique Animal ID
- **Update existing animal records** with automatic classification recalculation
- **Delete animal records** after confirmation
- **Automatically determine** an animal's rehabilitation status and housing unit based on its recovery score
- **Generate summary reports** containing key rehabilitation statistics
- **Data Persistence:** Store and retrieve data using text file storage (`.txt`)

---

## Project Architecture
The project follows a clean **Layered Architecture**:

```
├── Presentation Layer    (UI / Windows Forms)
├── Application Logic Layer (Business Logic & Class Rules)
└── Data Layer           (File Handling & Persistence)
```

---

## Technologies Used
* **Language:** C#
* **Framework:** .NET Windows Forms
* **Data Storage:** Text File Data Storage (`.txt`)
* **Version Control:** Git & GitHub

---

## System Features

### Core Operations
* **Add Animal:** Allows rehabilitation staff to register a new animal into the system while validating all entered information before saving.
* **View Animals:** Displays all available animal records in a `DataGridView` for easy monitoring and management.
* **Search Animal:** Allows users to locate a specific animal using its unique Animal ID.
* **Update Animal:** Enables modification of animal information while maintaining data integrity and recalculating rehabilitation classifications when required.
* **Delete Animal:** Allows users to permanently remove an animal record after confirmation.
* **Summary Reporting:** Generates a comprehensive report containing:
  * Total number of animals
  * Average animal age
  * Average recovery score
  * Breakdown of animals per rehabilitation status

---

### Automatic Classification

#### 1. Rehabilitation Status
| Recovery Score | Status |
| :---: | :--- |
| `0 - 19` | Critical |
| `20 - 39` | Serious |
| `40 - 59` | Stable |
| `60 - 79` | Recovering |
| `80 - 100` | Release-Ready |

#### 2. Housing Unit Allocation
| Recovery Score | Housing Unit |
| :---: | :--- |
| `0 - 19` | Intensive Care Unit |
| `20 - 39` | High-Dependency Ward |
| `40 - 59` | Recovery Ward |
| `60 - 79` | Outdoor Enclosure |
| `80 - 100` | Pre-Release Camp |

---

## Team Members & Responsibilities

| Team Member | Primary Responsibilities | Contact & Links |
| :--- | :--- | :--- |
| **Brandon Zander Purcell** | • Delete Animal Feature<br>• Summary Report Generation<br> | [![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/REPLACE-BRANDON-LINKEDIN) [![GitHub](https://img.shields.io/badge/GitHub-Profile-black?style=flat&logo=github)](https://github.com/REPLACE-BRANDON-GITHUB) |
| **Naledi Mnisi** | • Add Animal Feature<br>• Animal Registration Workflow | [![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/REPLACE-NALEDI-LINKEDIN) [![GitHub](https://img.shields.io/badge/GitHub-Profile-black?style=flat&logo=github)](https://github.com/REPLACE-NALEDI-GITHUB) |
| **Ethan Wood** | • Search Animal Feature<br>• Update Animal Feature | [![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue?style=flat&logo=linkedin)](https://www.linkedin.com/in/REPLACE-ETHAN-LINKEDIN) [![GitHub](https://img.shields.io/badge/GitHub-Profile-black?style=flat&logo=github)](https://github.com/REPLACE-ETHAN-GITHUB) |

---

## Development Standards
- Meaningful commit messages
- Pull Requests required prior to merging
- No direct development on the `main` branch
- Consistent C# coding conventions
- Collaborative code reviews
- Regular testing throughout development

---

## Academic Declaration
This project was developed as part of the requirements for the **PRG2782** module. The application was designed and implemented by the listed team members using concepts taught within the course, including layered architecture, object-oriented programming principles, file handling, input validation, and source control management using Git and GitHub.

---

&copy; 2026 PRG2782 Group Project — Baobab Ridge Wildlife Rehabilitation Centre
