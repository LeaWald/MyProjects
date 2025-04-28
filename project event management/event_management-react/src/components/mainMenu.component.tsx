import { NavLink } from "react-router"

export const MainMenu =()=>{
    return <nav>
        <NavLink to="/producer"> מפיקות </NavLink>
        <NavLink to="/user">משתמשים רגילים </NavLink>
    </nav>
}