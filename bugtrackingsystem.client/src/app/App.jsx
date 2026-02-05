// Defines Routes
// Applies layout

import {Routes, Route} from 'react-router-dom';
import Mainlayout from './layout/MainLayout.jsx';
import BugForm from '../features/bugs/pages/BugForm.jsx';
import BugList from '../features/bugs/pages/BugList.jsx';

function App() {
  return (
    <Routes>
      <Route element={<Mainlayout />} >
        <Route index element={<h1>Welcome to Bug Tracking System</h1>}/>
         <Route path="/report-bug" element={<BugForm />}/> 
         <Route path="/bug-list" element={<BugList />} />
    </Route>
    </Routes>
  );
}

export default App;