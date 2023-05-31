import { NavLink } from "react-router-dom";
import './Nav.css'
const Navigation = () => 
{
    return(<>
        <NavLink to={'/'}><button className="home-btn">Start</button></NavLink>
    </>)
}

export default Navigation;