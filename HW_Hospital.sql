--use HospitalMart

--select w.[NameWard], w.[Places] 
--from Ward as w
--where w.Id = 2 and w.Places >= 5 and 15 < ANY(select Places	from Ward where Id = 2)

--select d.NameDepartments 
--from Departments as d 
--join Ward as w on d.Id = w.Id 
--join DoctorsExaminations as doc on w.Id = doc.WardId
--where DATEADD(DD, -1000, GETDATE()) < ANY(	select [DateExam] from DoctorsExaminations as de2 where de2.WardId = w.Id and w.Id = d.Id)

--select dis.NameDieases
--from Dieases as dis left join DoctorsExaminations as de
--on dis.Id = de.DieasesId
--where dis.Id not in (select DieasesId from DoctorsExaminations)

--select doc.Name + ' ' + doc.Surname as 'Full Name'
--from Doctors as doc left join DoctorsExaminations as de
--on doc.Id = de.DoctorId
--where doc.Id not in (select DoctorId from DoctorsExaminations)

--select d.NameDepartments
--from Departments as d left join Ward as w 
--on d.Id = w.Id
--left join DoctorsExaminations as de on de.WardId = w.Id
--where d.Id not in (select w.Id from Ward as w join DoctorsExaminations as de on de.WardId = w.Id)

--select doc.Surname
--from Doctors as doc join Interns as i 
--on doc.Id = i.DoctorId

--select doc.Surname
--from Doctors as doc join Interns as i
--on doc.Id = i.DoctorId
--where doc.Salary > ANY(select Salary from Doctors where DoctorId not in (select DoctorID from Interns))

--select w.NameWard
--from Ward as w join Departments as d on w.Id = d.Id
--where w.Places > ALL(select Places from Ward where Id = 1)

--select d.Surname from Doctors as d join DoctorsExaminations as de 
--									on d.[ID] = de.DoctorId join Ward as w 
--									on de.WardId = w.Id join Departments as dp
--									on dp.Id = w.Id
--where dp.NameDepartments = 'Kiev' or dp.NameDepartments = 'y'

--select di.NameDieases, Count(de.DieasesId) from DoctorsExaminations as de join Dieases as di on de.DieasesId = di.Id
--group by di.NameDieases