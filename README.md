Here’s a tighter, easier-to-scan version with cleaner sections and less repetition. I kept your intent and wording style, just made it more “follow-the-steps” friendly.

---

# RaccoonPro – Module 0 (Programming & .NET Orientation)

This repo contains **Module 0 demo projects**.

**Module 0 is an orientation (not a full course).**
It’s meant to show what programming looks like and help you decide if you want to continue.

You will see:

* A simple console program
* The same program improved step-by-step
* A tiny Web API glimpse

---

## Folder Layout

Everything you run is in `src`.

```
├── shared
│   ├── docs
│   └── scripts
└── src
    ├── 01-beginner-console
    ├── 02-intermediate-defensive
    ├── 03-intermediate-refactor
    └── 04-webapi-glimpse
```

---

## Projects (What each one demonstrates)

### 01 — beginner console

* Reads input → makes a decision → prints output
* Minimal logic, no validation

### 02 — defensive version

* Same program
* Handles bad input safely (real users type nonsense)

### 03 — refactor version

* Same behavior and rules
* Cleaner structure using methods

### 04 — web api glimpse

* Very small Web API
* Same rule: `age >= 18`
* Shows how logic runs in a web app

---

## Requirements (Install these)

### 1) .NET 10 SDK

Install **.NET 10 SDK** (not just runtime).

Verify:

* Open **Command Prompt**
* Run: `dotnet --version`
* Expect: `10.0.xxx`

If `dotnet` isn’t recognized:

* Restart your computer and try again

### 2) Visual Studio 2026 Community

Install **Visual Studio Community 2026**, select workloads:

* **ASP.NET and web development**
* **.NET desktop development**

---

## Get the Code (No Git required)

Recommended:

* Download ZIP from your instructor
* Extract it
* Open the `.sln` file

> Git is optional and not needed for Module 0.

---

## Run a Project (Visual Studio)

1. In **Solution Explorer**, expand `src`
2. Right-click a project → **Set as Startup Project**
3. Press **F5** (or click Run)

---

## What to Try

### Console projects (01–03)

Try:

* Name: `Alex`
* Age: `18` → allowed
* Age: `17` → not allowed
* Age: `abc` → handled safely in **02** and **03**

### Web API (04)

1. Set `04-webapi-glimpse` as Startup Project
2. Press **F5**
3. In browser try:

* `/`
* `/access?age=18`
* `/access?age=17`

Expected: JSON output.

---

## Common Issues

**Framework not found**

* If you see “Microsoft.NETCore.App was not found”: install the required SDK version and restart Visual Studio.

**`dotnet` not recognized**

* Restart PC
* Ensure you installed the **SDK**, not runtime only

**HTTPS certificate prompt**

* Click **Yes** (normal for local dev)

---

## Optional: Git (Later)

If you already know Git:
`git clone <REPLACE_WITH_REPO_URL>`

---

If you want, I can also do a **“spoken version”** that reads cleanly for a recording (shorter sentences, fewer headings, more “do this next” pacing).
