import { Outlet, Link } from "react-router-dom";
import './MainLayout.css';


export default function MainLayout() {
  return (
    <div className="layout">
        <header>
            <h2>Bug Tracking System</h2>
        </header>

        <nav>
            <Link to="/">Home</Link> | {" "}
            <Link to="/report-bug">Report a Bug</Link> | {" "}
            <Link to="/bug-list">Bug List</Link>
        </nav>

        <main>
            <Outlet />
        </main>

    </div>
  );
}
