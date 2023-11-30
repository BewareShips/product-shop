import React from 'react';
import AppRouter from './router';
import Login from './pages/auth/Login';

const App: React.FC = () => {
  return (
    <div className="App">
      <AppRouter />
      <Login/>
    </div>
  );
};

export default App;