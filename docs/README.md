
# 🏥 Hospital System

A hospital management system built in C# / .NET, supporting multiple user roles, reservations, and equipment management.

---

## ⚙️ Packages
- 🖤 FontAwesome.Sharp

---

## 🗄️ Database Overview
---

## 🖼️ Screenshots

<img width="975" height="594" alt="image" src="https://github.com/user-attachments/assets/7dca0458-91da-461a-a322-24125674fee6" />

---

**Tables:**

- 👤 **DK_USERS** – Stores all users (Managers, Doctors, Employees, Clients).  
  - Initial manager: `menaxherja@gmail.com` / `!123456Mm`  
  - Managers can create other users. Clients self-register.  

- 🏥 **SERVICE** – All hospital services.  
- 🛠️ **EQUIPMENTS** – All equipment; linked to services via foreign keys.  
- 👨‍⚕️ **DOCTOR** – Doctor details; linked to services and equipment.  
- 📅 **RESERVATION** – Tracks reservations; links to users and doctors.  
- 🔗 **QRSTRING** – Stores QR code data for reservations.

---

## 👥 User Roles

### 🧑‍💼 Manager
- Create, edit, delete users.  
- Add/edit services and equipment.  

### 👨‍⚕️ Doctor
- Specify offered services and equipment.  
- Manage personal calendar (view/add/edit reservations).  

### 🧑‍💻 Employee
- Access full hospital calendar.  
- Manage all reservations (add/edit/delete/start/cancel).  
- Send results via email.  
- Scan QR codes to access reservations.

### 👤 Client
- View available services & equipment.  
- Submit reservations.  
- View reservation details and print tables.  
- Access hospital calendar like doctors.

---

## 📅 Reservation Flow

1. ✉️ User provides patient contact email.  
2. 🏥 Select service → available doctors are shown.  
3. 👨‍⚕️ Choose doctor → only free time slots appear.  
4. ✅ Confirmation sends email with reservation ID + QR code.  
5. 📧 Clients receive email notifications for any changes.  
6. 📱 Employees can scan QR code to act on reservation.

---

## 📊 Reports & Analytics

- 📈 Monthly and yearly graphs for completed, canceled, and total reservations.  
- 📝 "Reports" tab allows filtering and exporting reservation data.


## 🔗 Notes

- 🗝️ Database maintains proper foreign key relationships.  
- 📲 QR codes simplify tracking reservations.  
- 🔐 Role-based access ensures security and correct permissions.
