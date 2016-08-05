Use MicaDiy ;
Select c.CUS_CODE , CUS_LNAME + CUS_FNAME, INV_NUMBER, INV_DATE -- LEGACY CODE
from Customer c, Invoice i
WHERE c.CUS_CODE = i.CUS_CODE

Select c.CUS_CODE , CUS_LNAME + CUS_FNAME, INV_NUMBER, INV_DATE -- ANSI CODE
from Customer c INNER JOIN Invoice i
ON c.CUS_CODE = i.CUS_CODE


